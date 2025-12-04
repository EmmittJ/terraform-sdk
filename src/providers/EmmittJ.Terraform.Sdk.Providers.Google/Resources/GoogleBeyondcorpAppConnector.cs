using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for principal_info in GoogleBeyondcorpAppConnector.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpAppConnectorPrincipalInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principal_info";

    /// <summary>
    /// ServiceAccount block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceAccount block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public required TerraformList<GoogleBeyondcorpAppConnectorPrincipalInfoBlockServiceAccountBlock> ServiceAccount
    {
        get => GetRequiredArgument<TerraformList<GoogleBeyondcorpAppConnectorPrincipalInfoBlockServiceAccountBlock>>("service_account");
        set => SetArgument("service_account", value);
    }

}

/// <summary>
/// Block type for service_account in GoogleBeyondcorpAppConnectorPrincipalInfoBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpAppConnectorPrincipalInfoBlockServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_account";

    /// <summary>
    /// Email address of the service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBeyondcorpAppConnector.
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpAppConnectorTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_beyondcorp_app_connector Terraform resource.
/// Manages a google_beyondcorp_app_connector resource.
/// </summary>
public partial class GoogleBeyondcorpAppConnector(string name) : TerraformResource("google_beyondcorp_app_connector", name)
{
    /// <summary>
    /// An arbitrary user-provided name for the AppConnector.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// ID of the AppConnector.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the AppConnector.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Represents the different states of a AppConnector.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// PrincipalInfo block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrincipalInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrincipalInfo block(s) allowed")]
    public required TerraformList<GoogleBeyondcorpAppConnectorPrincipalInfoBlock> PrincipalInfo
    {
        get => GetRequiredArgument<TerraformList<GoogleBeyondcorpAppConnectorPrincipalInfoBlock>>("principal_info");
        set => SetArgument("principal_info", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBeyondcorpAppConnectorTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBeyondcorpAppConnectorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
