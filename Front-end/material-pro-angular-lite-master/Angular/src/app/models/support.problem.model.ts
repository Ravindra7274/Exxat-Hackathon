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
    queryId:string;
    description:string;
    context:string;
    moduleId:string;
    InitialQuery:string;
    InputParams:Array<string>;
    Troubleshoot:SupportProblem[];

    SupportTroubleshoot(problem){
        this.queryId=problem.queryId || '';
        this.description=problem.description || '';
        this.context=problem.context || '';
        this.moduleId=problem.moduleId || '';
        this.InitialQuery=problem.InitialQuery || '';
        this.InputParams=problem.InputParams || [];
        this.Troubleshoot=problem.Troubleshoot || [];
    }
    
}