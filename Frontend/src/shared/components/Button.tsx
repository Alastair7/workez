import React from "react"
import './Button.css'

export interface ButtonProps extends React.ButtonHTMLAttributes<HTMLButtonElement> {
  text: string
}

export const Button = React.forwardRef<HTMLButtonElement, ButtonProps>(({ text = "", ...props }, ref) => {
  return (
    <button className="button" ref={ref} {...props}>{text}</button>
  );
})
