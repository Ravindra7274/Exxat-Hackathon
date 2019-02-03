import { SupportTroubleshoot } from "./support.troubleshoot.model";


// export class SupportProblem{
//     PreCheckName:string;
//     InitialQuery:string;
//     Troubleshoot:SupportTroubleshoot[];

//     SupportProblem(problem){
//         this.PreCheckName=problem.PreCheckName || '';
//         this.InitialQuery=problem.InitialQuery || '';
//         this.Troubleshoot=problem.Troubleshoot || '';
//     }
// }

export class SupportProblem{
    QueryName:string;
    InitialQuery:string;
    InputParams:Array<string>
    Troubleshoot:SupportProblem[];

    SupportTroubleshoot(problem){
        this.QueryName=problem.QueryName || '';
        this.InitialQuery=problem.InitialQuery || '';
        this.InputParams=problem.InputParams || [];
        this.Troubleshoot=problem.Troubleshoot || [];
    }
    
}