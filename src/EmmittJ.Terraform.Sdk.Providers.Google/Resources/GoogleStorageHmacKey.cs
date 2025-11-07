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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The email address of the key&#39;s associated service account.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("service_account_email");
        set => this.WithProperty("service_account_email", value);
    }

    /// <summary>
    /// The state of the key. Can be set to one of ACTIVE, INACTIVE. Default value: &amp;quot;ACTIVE&amp;quot; Possible values: [&amp;quot;ACTIVE&amp;quot;, &amp;quot;INACTIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
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
