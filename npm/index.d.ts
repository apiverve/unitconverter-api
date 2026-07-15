declare module '@apiverve/unitconverter' {
  export interface unitconverterOptions {
    api_key: string;
    secure?: boolean;
  }

  /**
   * Describes fields the current plan does not unlock. Locked fields arrive as null
   * in `data`; `locked_fields` names them, using dot paths for nested fields.
   * Absent when the plan unlocks everything.
   */
  export interface PremiumInfo {
    message: string;
    upgrade_url: string;
    locked_fields: string[];
  }

  export interface unitconverterResponse {
    status: string;
    error: string | null;
    data: UnitConverterData;
    code?: number;
    premium?: PremiumInfo;
  }


  interface UnitConverterData {
      result:          Result;
      unitDefinitions: UnitDefinitions;
  }
  
  interface Result {
      result: number | null;
      from:   null | string;
      to:     null | string;
  }
  
  interface UnitDefinitions {
      from: From;
      to:   From;
  }
  
  interface From {
      abbr:     null | string;
      measure:  null | string;
      system:   null | string;
      singular: null | string;
      plural:   null | string;
  }

  export default class unitconverterWrapper {
    constructor(options: unitconverterOptions);

    execute(callback: (error: any, data: unitconverterResponse | null) => void): Promise<unitconverterResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: unitconverterResponse | null) => void): Promise<unitconverterResponse>;
    execute(query?: Record<string, any>): Promise<unitconverterResponse>;
  }
}
