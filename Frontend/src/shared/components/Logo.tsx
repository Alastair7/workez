import WorkezLogo from './../../assets/product/workez.svg'
import './Logo.css'

export const Logo = () => {
  return (
    <div className='logo'>
      <img src={WorkezLogo} />
      <h1>Work</h1>
      <h1 id='logo__wordez'>EZ</h1>
    </div>
  );
}
