using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIapClientTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_iap_client resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleIapClient : TerraformResource
{
    public GoogleIapClient(string name) : base("google_iap_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("client_id");
        this.WithOutput("secret");
    }

    /// <summary>
    /// Identifier of the brand to which this client
    /// is attached to. The format is
    /// &#39;projects/{project_number}/brands/{brand_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Brand is required")]
    public required TerraformProperty<string> Brand
    {
        get => GetRequiredProperty<TerraformProperty<string>>("brand");
        set => this.WithProperty("brand", value);
    }

    /// <summary>
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIapClientTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIapClientTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Unique identifier of the OAuth client.
    /// </summary>
    public TerraformExpression ClientId => this["client_id"];

    /// <summary>
    /// Output only. Client secret of the OAuth client.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

}
