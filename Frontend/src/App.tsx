import { Route, Routes } from 'react-router'
import './App.css'
import { RouteGuard } from './features/router/RouteGuard'
import { HomePage } from './pages/home/HomePage'
import { CallbackPage } from './pages/general/CallbackPage'
import { LandingPage } from './pages/landing/LandingPage'
import { NotFoundPage } from './pages/general/NotFoundPage'

function App() {
  return (
    <Routes>
      <Route path="/" element={
        <RouteGuard>
          <HomePage />
        </RouteGuard>
      } />
      <Route path="callback" element={<CallbackPage />} />
      <Route path="login" element={<LandingPage />} />
      <Route path="*" element={<NotFoundPage />} />
    </Routes>
  )
}

export default App
