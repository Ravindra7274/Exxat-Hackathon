
export class SupportTroubleshoot{
    TroubleshootName:string;
    DetectionQuery:string;
    ResolvingQuery:string;

    SupportTroubleshoot(troubleshoot){
        this.TroubleshootName=troubleshoot.TroubleshootName || '';
        this.DetectionQuery=troubleshoot.DetectionQuery || '';
        this.ResolvingQuery=troubleshoot.ResolvingQuery || '';
    }
}