import { useStopwatch } from "react-timer-hook";
import { Button } from "../../shared/components/Button";
import './WorkTimer.css'
import { getInitButtonText } from "./utils";

export const WorkTimer = () => {
  const {
    isRunning,
    seconds,
    minutes,
    hours,
    start,
    pause,
    reset
  } = useStopwatch({ autoStart: false });


  const initButtonText = getInitButtonText(seconds, minutes, hours, isRunning)

  return (
    <div className="work-timer">
      <div className="work-timer--numbers">
        <span>{hours}</span>:<span>{minutes}</span>:<span>{seconds}</span>
      </div>
      <div className="work-timer--buttons">
        <Button text={initButtonText} onClick={start} disabled={isRunning} />
        <Button text="Pause" onClick={pause} disabled={!isRunning} />
        <Button text="Finish" onClick={() => reset(undefined, false)} />
      </div>
    </div>
  );
}
