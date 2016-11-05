
var viennaAlbedo = L.imageOverlay('img/layers/vienna_albedo.png',[[45.90, 12.28], [48.75, 19.21]], { opacity: 0.98});

var map = new L.Map('map', {
 layers: [viennaAlbedo]
});

var osmUrl='http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png';

var osmAttrib='Map data © <a href="http://openstreetmap.org">OpenStreetMap</a> contributors';

var osm = new L.TileLayer(osmUrl, {minZoom: 8, maxZoom: 12, attribution: osmAttrib});	

map.setView(new L.LatLng(48.2, 16.4),11);
map.addLayer(osm);

L.geoJson(viennaGeoJson, {
  style: function() {
  },
  onEachFeature: onEachFeature
}).addTo(map);

var viennaPopup = L.popup()
  .setLatLng([48.2, 16.4])
  .setContent(`
  <div style='width:220px'></div>
  <div>
    <strong>Avg albedo:</strong> <div style='float:right'>0.705910</div>
  </div>
  <div>
    <strong>Avg temperature(&#x2103;):</strong>
    <div style='float:right'>23.27</div>
  </div>
    <div><strong>Avg irradiation(Wh/m<sup>2</sup> - BHI):</strong>
    <div style='float:right;line-height:1.9em'>135.7829</div>
  </div>`);

function onEachFeature(feature, layer) {
  layer.on('click', function() {
    viennaPopup.openOn(map);   
  });
}

L.control.layers(null,{ "albedo": viennaAlbedo }).addTo(map);
