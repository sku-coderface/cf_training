use std::io;
use std::io::Write;

fn main() {
    print!("What is the input string? ");
    io::stdout().flush().unwrap(); // 놓친 부분 : unwrap() 빼먹음

    // 잘못 쓴 코드: let input = io::stdin90.read_line();
    let mut input: String = String::new();
    io::stdin().read_line(&mut input).unwrap(); // 놓친 부분 : unwrap() 빼먹음

    while match input.chars().last().unwrap() { // 놓친 부분 : unwrap() 빼먹음
        '\r' | '\n' => true,
        _ => false
    } {
        input.pop();
    };

    print!("{0} has {1} characters.", input, input.len())
}