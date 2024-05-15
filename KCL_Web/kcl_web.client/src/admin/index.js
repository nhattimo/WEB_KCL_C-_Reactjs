import React from 'react'
import { createRoot } from 'react-dom/client'
import { Provider } from 'react-redux'
import 'core-js'

import App from './App'
import store from './store'

function adminApp() {
  <Provider store={store}>
    <App />
  </Provider>
}
export default adminApp();  