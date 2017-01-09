; author: miles3898
; language: clojure

(defn simpleMath []
 (let
   [
     [fst snd]
     [(atom 0) (atom 0)]
   ]
   (println "Please input the first number.")
  (reset! fst (read))
  (println "Please input the second number.")
  (reset! snd (read))
  
  (let
   [
    [x y]
    [@fst @snd]
   ]
   (when (and (integer? x) (integer? y) (> x 0) (> y 0))
    (println (str x " + " y " = " (+ x y)))
    (println (str x " - " y " = " (- x y)))
    (println (str x " " y " = " ( x y)))
    (println (str x " / " y " = " (/ x y)))
   )
  )
 )
 nil
)
