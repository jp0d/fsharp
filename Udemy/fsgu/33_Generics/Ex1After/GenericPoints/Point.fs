namespace GenericPoints
 
type Point<'T> = 
    {
        X : 'T
        Y : 'T
    }
 
module Point =
 
    let inline moveBy (dx : 'T) (dy : 'T) (p : Point<'T>) =
        {
            X = p.X + dx
            Y = p.Y + dy
        }
