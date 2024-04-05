use std::{io};
use std::cmp::Ordering;
use rand::Rng;

fn main() {

    loop {

        let secret = rand::thread_rng().gen_range(1..=100);
        println!("Secret number: {}", secret);
        let mut guess = String::new();
        io::stdin()
            .read_line(&mut guess)
            .expect("Error reading");
        println!("You guess {guess}");
        let guess: u32 = match guess.trim().parse() {
            Ok(num) => num,
            Err(_) => continue,
        };
    
        match guess.cmp(&secret) {
            Ordering::Less => println!("Too small"),
            Ordering::Greater => println!("Too big"),
            Ordering::Equal => {
                println!("You win");
                break;
            },
        }
    }

}