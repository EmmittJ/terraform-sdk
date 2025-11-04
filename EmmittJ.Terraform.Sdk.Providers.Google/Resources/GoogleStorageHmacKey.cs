using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_hmac_key resource.
/// </summary>
public class GoogleStorageHmacKey : TerraformResource
{
    public GoogleStorageHmacKey(string name) : base("google_storage_hmac_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_id");
        this.DeclareOutput("secret");
        this.DeclareOutput("time_created");
        this.DeclareOutput("updated");
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email address of the key&#39;s associated service account.
    /// </summary>
    public string? ServiceAccountEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account_email")?.Value;
        set => this.WithProperty("service_account_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state of the key. Can be set to one of ACTIVE, INACTIVE. Default value: &amp;quot;ACTIVE&amp;quot; Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;INACTIVE&amp;quot;]
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access ID of the HMAC Key.
    /// </summary>
    public TerraformExpression AccessId => this["access_id"];

    /// <summary>
    /// HMAC secret key material.
    /// </summary>
    public TerraformExpression Secret => this["secret"];

    /// <summary>
    /// &#39;The creation time of the HMAC key in RFC 3339 format. &#39;
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// &#39;The last modification time of the HMAC key metadata in RFC 3339 format.&#39;
    /// </summary>
    public TerraformExpression Updated => this["updated"];

}
