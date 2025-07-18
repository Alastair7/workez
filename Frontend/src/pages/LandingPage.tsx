import { Button } from '../shared/components/Button'
import WorkezLogo from './../assets/product/workez.svg'
import { useAuth0 } from '@auth0/auth0-react'
import './LandingPage.css'

export const LandingPage = () => {
  const { loginWithRedirect } = useAuth0()
  const handleLogin = () => loginWithRedirect()

  return <>
    <div className='logo'>
      <img src={WorkezLogo} />
      <h1>Work</h1>
      <h1 id='logo__wordez'>EZ</h1>
    </div>
    <h2>Work easy and keep grinding</h2>
    <div className='login'>
      <Button onClick={handleLogin} text='Login with Google' />
    </div>
  </>
}
