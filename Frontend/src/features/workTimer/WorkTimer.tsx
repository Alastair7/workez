import { useState } from "react";
import { useTimer } from "react-timer-hook";

type Props = {
  timeLimit: number
}

export const WorkTimer = ({ timeLimit }: Props) => {
  const limitDate = new Date()
  const { minutes, hours, isRunning, start, pause, resume } = useTimer({ expiryTimestamp: timeLimit })

  return (
    <div className="work-timer">

    </div>
  );
}
