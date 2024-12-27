let x = 10
let y = 20

let add x y = 
    let x1 = x + y
    let y1 = y + x1 
    (x1, y1, x1 + y1)

let (x1, y1, result) = add x y
printf "%d %d %d" x1 y1 result