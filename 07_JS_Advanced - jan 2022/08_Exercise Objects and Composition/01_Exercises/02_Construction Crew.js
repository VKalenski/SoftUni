function demo(object) {
    if (object.dizziness) {
        object.levelOfHydrated += 0.1 * object.experience * object.weight;
        object.dizziness = false;
    }
    return object;
}

demo({
    weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true
});