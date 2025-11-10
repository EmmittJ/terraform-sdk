using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeDeveloperAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeDeveloperTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_apigee_developer resource.
/// </summary>
public class GoogleApigeeDeveloper : TerraformResource
{
    public GoogleApigeeDeveloper(string name) : base("google_apigee_developer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("last_modified_at");
        SetOutput("organizatio_name");
        SetOutput("status");
        SetOutput("email");
        SetOutput("first_name");
        SetOutput("id");
        SetOutput("last_name");
        SetOutput("org_id");
        SetOutput("user_name");
    }

    /// <summary>
    /// Email address of the developer. This value is used to uniquely identify the developer in Apigee hybrid. Note that the email address has to be in lowercase only..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
    }

    /// <summary>
    /// First name of the developer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    public required TerraformProperty<string> FirstName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("first_name");
        set => SetProperty("first_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Last name of the developer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    public required TerraformProperty<string> LastName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("last_name");
        set => SetProperty("last_name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// User name of the developer. Not used by Apigee hybrid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleApigeeDeveloperAttributesBlock>? Attributes
    {
        set => SetProperty("attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeDeveloperTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    public TerraformExpression LastModifiedAt => this["last_modified_at"];

    /// <summary>
    /// Name of the Apigee organization in which the developer resides.
    /// </summary>
    public TerraformExpression OrganizatioName => this["organizatio_name"];

    /// <summary>
    /// Status of the developer. Valid values are active and inactive.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
