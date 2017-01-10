import Foundation

let year = Calendar.current.component(.year, from: Date())
	print("What is your current age?", separator: "", terminator: " ")
	guard let age = Int(readLine()!) else {
		    exit(1)
	}
print("At what age would you like to retire?", separator: "", terminator: " ")
guard let retire = Int(readLine()!) else {
	    exit(1)
}

let left = retire - age
print("You habe \(left) years left until you can retire.")
print("It's \(year), so you can retire in \(year + left).")
