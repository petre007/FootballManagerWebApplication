export class UserInstance {

    private static instance : UserInstance;

    private _id : number | undefined;

    private _username : string | undefined;
    
    private _context : string | undefined;

    private constructor() {}

    public static get Instance() {
        return this.instance || (this.instance = new this());
    }

    get id(): number | undefined {
        return this.id;
    }

    set id(id: number | undefined) {
        this._id = id;
    }

    get username(): string | undefined {
        return this._username;
    }

    set username(username: string | undefined) {
        this._username = username;
    }

    
    get context(): string | undefined {
        return this._context;
    }

    set context(context: string | undefined) {
        this._context = context;
    }
}
