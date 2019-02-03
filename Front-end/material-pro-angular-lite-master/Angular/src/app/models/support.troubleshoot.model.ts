
//import { SupportTroubleshoot } from "./support.troubleshoot.model";

export class SupportTroubleshoot{
    Name:string;
    DetectionQuery:string;
    ResolvingQuery:string;

    SupportProblem(troubleshoot){
        this.Name=troubleshoot.Name || '';
        this.DetectionQuery=troubleshoot.DetectionQuery || '';
        this.ResolvingQuery=troubleshoot.ResolvingQuery || '';
    
}
}