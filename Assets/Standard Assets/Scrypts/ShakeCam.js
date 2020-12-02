var ObjToShake : Transform;
 
function Update() {
 
        var randNrX = Random.Range(0.7,-0.7);
        var randNrY = Random.Range(0.7,-0.7);
        var randNrZ = Random.Range(0.7,-0.7);
        ObjToShake.transform.position += Vector3(randNrX,randNrY,randNrZ);
}