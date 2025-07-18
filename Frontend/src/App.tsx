import { Auth0Provider } from '@auth0/auth0-react'
import './App.css'
import { BrowserRouter } from 'react-router'
import { Router } from './features/router/Router'

function App() {
  return (
    <Auth0Provider domain={import.meta.env.VITE_AUTH0_DOMAIN} clientId={import.meta.env.VITE_AUTH0_CLIENT_ID} authorizationParams={{ redirect_uri: "http://localhost:5173/home" }}>
      <BrowserRouter>
        <Router />
      </BrowserRouter>
    </Auth0Provider>
  )
}

export default App
