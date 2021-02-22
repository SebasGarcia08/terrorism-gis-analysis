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
                marker.ToolTipText = (string)db.Rows[i]["iyear"] + "/" + (string)db.Rows[i]["imonth"] + "/" + (string)db.Rows[i]["iday"] + "\n" + (string)db.Rows[i]["attacktype1_txt"];
                markers.Markers.Add(marker);
            }
        }

        private void load_attacks()
        {
            foreach (DataRow row in db.Rows)
            {
                double lat = double.Parse((string)row["latitude"], CultureInfo.InvariantCulture);
                double lng = double.Parse((string)row["longitude"], CultureInfo.InvariantCulture);

                PointLatLng p = new PointLatLng(lat, lng);

                points.Add(p);
            }

            setMarkers();
            points.Clear();
        }

        public void SetDabatase(DataTable dt)
        {
            db = dt;
        }
    }
}
