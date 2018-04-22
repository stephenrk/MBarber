//intialize the map
function initialize() {
  var mapOptions = {
      zoom: 16.75,
    scrollwheel: false,
      center: new google.maps.LatLng(-23.6674086, -46.7816406),
    mapTypeControl: false
  };

var map = new google.maps.Map(document.getElementById('map-canvas'),
      mapOptions);


// MARKERS
/****************************************************************/

//add a marker1
var marker = new google.maps.Marker({
    position: new google.maps.LatLng(-23.6672793, -46.7792843),
    map: map,
    icon: '../Content/img/barbershop.png'
});

// INFO BOXES
/****************************************************************/

//show info box for marker1
    var contentString = '<div class="info-box"><img src="../Content/img/barbershop.png" class="info-box-img" alt="" /><h4>587 Smith Avenue</h4><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque in ultrices metus' + 
                    ' sit amet [...]</p><a href="property_single.html" class="button small">View Details</a><br/></div>';

var infowindow = new google.maps.InfoWindow({ content: contentString });

google.maps.event.addListener(marker, 'click', function() {
    infowindow.open(map,marker);
  });
}

google.maps.event.addDomListener(window, 'load', initialize);