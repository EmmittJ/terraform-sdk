using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleIapClient.
/// Nesting mode: single
/// </summary>
public class GoogleIapClientTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_iap_client Terraform resource.
/// Manages a google_iap_client resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleIapClient(string name) : TerraformResource("google_iap_client", name)
{
    /// <summary>
    /// Identifier of the brand to which this client
    /// is attached to. The format is
    /// &#39;projects/{project_number}/brands/{brand_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Brand is required")]
    public required TerraformValue<string> Brand
    {
        get => GetRequiredArgument<TerraformValue<string>>("brand");
        set => SetArgument("brand", value);
    }

    /// <summary>
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
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
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    public TerraformValue<string> ClientId
        => AsReference("client_id");

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    public TerraformValue<string> Secret
        => AsReference("secret");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIapClientTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIapClientTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
