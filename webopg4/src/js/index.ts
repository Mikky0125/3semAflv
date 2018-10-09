let OzToGrams = 28.34952;
let GramToOzs = 0.03527396195;
let ResultOutput:HTMLDivElement = <HTMLDivElement> document.getElementById("ResultOutput");

document.getElementById("GramToOz").addEventListener("click", () => GramToOz());
document.getElementById("OzToGram").addEventListener("click",() => OzToGram());

function ConvertGramToOz():number {
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("NumberText")).value);
    return inputWeight * GramToOzs;
}

function ConvertOzToGram():number {
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("NumberText")).value);
    return inputWeight * OzToGrams;
}

function GramToOz(){
    let result:number = ConvertGramToOz();
    if (result > 0){
        ResultOutput.innerHTML = result.toString() + "Oz";

    }

}

function OzToGram(){
    let result:number = ConvertOzToGram();
    if (result > 0){
        ResultOutput.innerHTML = result.toString() + " grams";
    }
}



