namespace GenericPoints
 
type Point = 
    {
        X : float
        Y : float
    }
 
module Point =
 
    let moveBy (dx : float) (dy : float) (p : Point) =
        {
            X = p.X + dx
            Y = p.Y + dy
        }
