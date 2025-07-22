import { WorkTimer } from "../../features/workTimer/WorkTimer"

import "./HomePage.css"
import { getDayName } from "./utils"
export const HomePage = () => {
  const today = new Date()

  const dayName = getDayName(today.toString(), "es-ES")

  const date = `${dayName}, ${today.getDate()}-${today.getMonth()}-${today.getFullYear()}`
  return (
    <div className="homepage">
      <h1>Welcome! User</h1>
      <h2>{date}</h2>
      <WorkTimer />
    </div>

  )
}
