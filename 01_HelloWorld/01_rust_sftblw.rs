use std::io; // stdin 함수를 쓰기 위해 필요
use std::io::Write; // io::stdout().flush().unwrap() 호출하는 데 필요

fn main() {
    print!("이름이 뭔가요? ");

    // print!() 는 이거 없으면 출력 안 됨. println!() 은 되는데...
    // 리눅스에서 \b 출력하는 거 같은 느낌?
    io::stdout().flush().unwrap(); // https://doc.rust-lang.org/std/macro.print!.html

    // stdio.rs 코드의 read_line 함수 예제코드 거의 그대로 씀.

    // let mut input:String = new String(); // new 없는듯
    let mut input: String = String::new(); // 변경될 수 있는 값이라 str 대신 String을 쓴 모양.
    match io::stdin().read_line(&mut input) { // &mut 빠지면 안 됨 // stdin()은 함수임
        // Ok, Err 는 result.rs에 pub enum Result<T, E> {} 로 있음
        Err(err) => panic!("read error: {}", err),
        _ => {} // Ok(n) 이 있으나 사용하지 않음
    };

    // 마지막 글자가 \r이거나 \n이면 pop하는 걸 반복
    // unwrap()은 enum Option {Some(x) None} 에서 None 이면 panic! 처리하고 아니면 Some의 x 반환.
    while match input.chars().last().unwrap() {  
      '\r' | '\n' => true , // input.pop() 한 번만 하면 윈도우에서는 '\r' 때문에 혼동 파게 망가
      _ => false
    } { // 와 while 안에 matchi가 있어 그냥 괄호가 두 개라니 변태같아...
      input.pop();
    }
    println!("{}님 반갑습니다. 만나서 반가워요!", input);
}