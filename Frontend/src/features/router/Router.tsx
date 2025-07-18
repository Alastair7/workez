import { Route, Routes } from 'react-router'
import { LandingPage } from '../../pages/LandingPage'
import { useAuth0 } from '@auth0/auth0-react'
import { HomePage } from '../../pages/HomePage'

export const Router = () => {
  const { isAuthenticated } = useAuth0()

  if (!isAuthenticated) {
    return <Routes>
      <Route index element={<LandingPage />} />
    </Routes>

  }

  return <Routes>
    <Route path="home" element={<HomePage />} />
  </Routes>
} 
