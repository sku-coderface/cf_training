#!/usr/local/bin/bash

echo -n "What is your current age? "
read age
echo -n "At what age would you like to retire? "
read retireAge
remain=$((retireAge - age))
echo "You have ${remain} years left until you can retire."
year=$(date +"%Y")
echo "It's ${year}", so you can retire in $((year + remain))
