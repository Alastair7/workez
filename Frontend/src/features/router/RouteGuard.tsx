import { useAuth0 } from "@auth0/auth0-react";
import type { ReactNode } from "react";
import { useLocation } from "react-router";
import { Navigate } from "react-router";

type Props = {
  children: ReactNode
}

export function RouteGuard({ children }: Props) {
  const { isAuthenticated } = useAuth0()
  const location = useLocation()


  return isAuthenticated ? children : <Navigate to={"/login"} replace state={{ path: location.pathname }} />;
}
