using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Globalization;

namespace terrorism_gis_analysis
{
    public partial class MapForm : Form
    {
        private List<PointLatLng> points;

        private GMapOverlay markers = new GMapOverlay("markers");

        private DataTable db;
        private List<string> ColsInToolTips;

        public MapForm()
        {
            InitializeComponent();

            points = new List<PointLatLng>();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;  //Service provider
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(3.42158, -76.5205); //Start position

            gmap.Overlays.Add(markers);

            load_attacks();
        }

        private void setMarkers()
        {
            for (int i = 0; i < points.Count; i++)
            {
                PointLatLng p = points[i];
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                foreach(string col in ColsInToolTips)
                {
                    marker.ToolTipText += col + ":" + db.Rows[i][col].ToString() + "\n";
                }
                markers.Markers.Add(marker);
            }
        }
        
        private void setMarkers(DataRow[] Rows)
        {
            for (int i = 0; i < points.Count; i++)
            {
                PointLatLng p = points[i];
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                foreach(string col in ColsInToolTips)
                {
                    marker.ToolTipText += col + ":" + Rows[i][col].ToString() + "\n";
                }
                markers.Markers.Add(marker);
            }
        }

        private void load_attacks()
        {
            foreach (DataRow row in db.Rows)
            {
                double lat = (double) row["latitude"];
                double lng = (double) row["longitude"];

                PointLatLng p = new PointLatLng(lat, lng);

                points.Add(p);
            }

            setMarkers();
            points.Clear();
        }
        
        public void ResetMap(DataRow[] rows)
        {
            markers.Clear();

            foreach (DataRow row in rows)
            {
                double lat = (double) row["latitude"];
                double lng = (double) row["longitude"];

                PointLatLng p = new PointLatLng(lat, lng);

                points.Add(p);
            }
            
            setMarkers(rows);
            points.Clear();
            
        }

        public void SetDabatase(DataTable dt)
        {
            db = dt;
        }

        public void SetColsInToolTips(List<string> headers)
        {
            this.ColsInToolTips = headers;
        } 
    }
}
