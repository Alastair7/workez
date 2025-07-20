import { useAuth0 } from '@auth0/auth0-react'
import './LandingPage.css'
import { Logo } from '../../shared/components/Logo'
import { Button } from '../../shared/components/Button'

export const LandingPage = () => {
  const { loginWithRedirect } = useAuth0()
  const handleLogin = async () => {
    await loginWithRedirect({ appState: { returnTo: "/" } })
  }

  return <>
    <Logo />
    <div className='login'>
      <Button onClick={handleLogin} text='Login with Google' />
    </div>
  </>
}
