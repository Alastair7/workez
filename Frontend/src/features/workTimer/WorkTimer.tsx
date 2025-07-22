import { useStopwatch } from "react-timer-hook";
import { Button } from "../../shared/components/Button";
import './WorkTimer.css'

export const WorkTimer = () => {
  const {
    seconds,
    minutes,
    hours,
    start,
    pause,
  } = useStopwatch({ autoStart: false });

  return (
    <div className="work-timer">
      <div className="work-timer--numbers">
        <span>{hours}</span>:<span>{minutes}</span>:<span>{seconds}</span>
      </div>
      <div className="work-timer--buttons">
        <Button text="Start Shift" onClick={start} />
        <Button text="Finish Shift" onClick={pause} />
      </div>
    </div>
  );
}
