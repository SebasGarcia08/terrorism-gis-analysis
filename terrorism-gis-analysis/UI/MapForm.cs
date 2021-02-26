using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Globalization;

namespace terrorism_gis_analysis.UI
{
    public partial class MapForm : Form
    {
        private readonly List<PointLatLng> Points;
        private readonly GMapOverlay Markers = new GMapOverlay("markers");

        private DataTable db;
        private List<string> ColsInToolTips;
        private bool Updated;
        
        public MapForm()
        {
            InitializeComponent();

            Points = new List<PointLatLng>();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;  //Service provider
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(3.42158, -76.5205); //Start position

            gmap.Overlays.Add(Markers);
            
            if(!Updated)
                LoadAttacks();
        }

        private void SetMarkers()
        {
            for (int i = 0; i < Points.Count; i++)
            {
                PointLatLng p = Points[i];
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                foreach(string col in ColsInToolTips)
                {
                    marker.ToolTipText += col + ":" + db.Rows[i][col].ToString() + "\n";
                }
                Markers.Markers.Add(marker);
            }
        }
        
        private void SetMarkers(DataRow[] rows)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                PointLatLng p = Points[i];
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                foreach(var col in ColsInToolTips)
                    marker.ToolTipText += col + " : " + rows[i][col] + "\n";
                Markers.Markers.Add(marker);
            }
        }

        private void LoadAttacks()
        {
            foreach (DataRow row in db.Rows)
            {
                double lat = (double) row["latitude"];
                double lng = (double) row["longitude"];

                PointLatLng p = new PointLatLng(lat, lng);

                Points.Add(p);
            }

            SetMarkers();
            Points.Clear();
        }
        
        public void ResetMap(DataRow[] rows)
        {
            Updated = true;
            
            Markers.Clear();
            
            foreach (DataRow row in rows)
            {
                double lat = (double) row["latitude"];
                double lng = (double) row["longitude"];

                PointLatLng p = new PointLatLng(lat, lng);

                Points.Add(p);
            }
            
            SetMarkers(rows);
            Points.Clear();
            
        }

        public void SetDatabase(DataTable dt)
        {
            db = dt;
        }

        public void SetColsInToolTips(List<string> headers)
        {
            this.ColsInToolTips = headers;
        } 
    }
}
