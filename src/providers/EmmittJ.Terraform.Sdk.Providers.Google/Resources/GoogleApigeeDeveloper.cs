using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in GoogleApigeeDeveloper.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeDeveloperAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// Key of the attribute
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeDeveloper.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeDeveloperTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apigee_developer Terraform resource.
/// Manages a google_apigee_developer resource.
/// </summary>
public partial class GoogleApigeeDeveloper(string name) : TerraformResource("google_apigee_developer", name)
{
    /// <summary>
    /// Email address of the developer. This value is used to uniquely identify the developer in Apigee hybrid. Note that the email address has to be in lowercase only..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// First name of the developer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    public required TerraformValue<string> FirstName
    {
        get => new TerraformReference<string>(this, "first_name");
        set => SetArgument("first_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Last name of the developer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    public required TerraformValue<string> LastName
    {
        get => new TerraformReference<string>(this, "last_name");
        set => SetArgument("last_name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// User name of the developer. Not used by Apigee hybrid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> LastModifiedAt
    {
        get => new TerraformReference<string>(this, "last_modified_at");
    }

    /// <summary>
    /// Name of the Apigee organization in which the developer resides.
    /// </summary>
    public TerraformValue<string> OrganizatioName
    {
        get => new TerraformReference<string>(this, "organizatio_name");
    }

    /// <summary>
    /// Status of the developer. Valid values are active and inactive.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Attributes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApigeeDeveloperAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformList<GoogleApigeeDeveloperAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeDeveloperTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeDeveloperTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
