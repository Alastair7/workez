import { Route, Routes } from 'react-router'
import { useAuth0 } from '@auth0/auth0-react'
import { HomePage } from '../../pages/home/HomePage'
import { LandingPage } from '../../pages/landing/LandingPage'

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
