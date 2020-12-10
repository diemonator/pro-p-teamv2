#toggle {
  display: none;
}

// Styles for the 'open' state, if the checkbox is checked
#toggle:checked {
  // Any element you need to change the style if menu is open goes here, using the sibling selector (~) as follows

  // Styles for the open navigation menu, for example
  & ~ .nav {
  }
}