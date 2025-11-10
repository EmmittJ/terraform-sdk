using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageHmacKeyTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutput("access_id");
        this.WithOutput("secret");
        this.WithOutput("time_created");
        this.WithOutput("updated");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformProperty<string> ServiceAccountEmail
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_account_email");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageHmacKeyTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageHmacKeyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
