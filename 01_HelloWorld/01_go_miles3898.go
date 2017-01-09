package main

import "fmt"

func main() {
  var name string
  
  fmt.Print("이름이 뭔가요?")
  fmt.Scanf("%s", &name)
  fmt.Printf("%s님 반갑습니다. 만나서 반가워요!\n", name)
}
