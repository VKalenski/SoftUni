function solve() {
    //one object with two methods
    let obj = {
        mage: function (input) {
            let objMage = {
                name: input,
                health: 100,
                mana: 100,
                cast: function (mageName) {
                    this.mana -= 1;
                    console.log(`${input} cast ${mageName}`);
                }
            }
            return objMage;
        },
        fighter: function (input) {
            let objFighter = {
                name: input,
                health: 100,
                stamina: 100,
                fight: function () {
                    this.stamina -= 1;
                    console.log(`${this.name} slashes at the foe!`);
                }
            }
            return objFighter;
        }
    }

    return obj;
}

let create = solve();
const scorcher = create.mage("Scorcher");
scorcher.cast("fireball")
scorcher.cast("thunder")
scorcher.cast("light")

const scorcher2 = create.fighter("Scorcher 2");
scorcher2.fight()

console.log(scorcher2.stamina);
console.log(scorcher.mana);

