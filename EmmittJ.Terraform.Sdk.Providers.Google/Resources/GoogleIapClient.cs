using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("client_id");
        this.DeclareOutput("secret");
    }

    /// <summary>
    /// Identifier of the brand to which this client
    /// is attached to. The format is
    /// &#39;projects/{project_number}/brands/{brand_id}&#39;.
    /// </summary>
    public string? Brand
    {
        get => GetProperty<TerraformLiteralProperty<string>>("brand")?.Value;
        set => this.WithProperty("brand", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Human-friendly name given to the OAuth client.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
