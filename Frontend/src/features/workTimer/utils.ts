export const getInitButtonText = (seconds: number, minutes: number, hours: number, isRunning: boolean) =>
  (seconds > 0 || minutes > 0 || hours > 0) || isRunning ? "Resume" : "Start Shift"
