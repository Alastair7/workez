import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import { BrowserRouter } from 'react-router'
import { AuthProviderNav } from './features/auth/AuthProviderNav.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <BrowserRouter>
      <AuthProviderNav>
        <App />
      </AuthProviderNav>
    </BrowserRouter>
  </StrictMode>
)
