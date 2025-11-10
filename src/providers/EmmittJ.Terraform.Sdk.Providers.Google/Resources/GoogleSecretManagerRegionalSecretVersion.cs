using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecretManagerRegionalSecretVersionTimeoutsBlock : TerraformBlock
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
/// Manages a google_secret_manager_regional_secret_version resource.
/// </summary>
public class GoogleSecretManagerRegionalSecretVersion : TerraformResource
{
    public GoogleSecretManagerRegionalSecretVersion(string name) : base("google_secret_manager_regional_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("customer_managed_encryption");
        this.WithOutput("destroy_time");
        this.WithOutput("location");
        this.WithOutput("name");
        this.WithOutput("version");
    }

    /// <summary>
    /// The deletion policy for the regional secret version. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned rather than deleted. Setting &#39;DISABLE&#39; allows the resource to be
    /// disabled rather than deleted. Default is &#39;DELETE&#39;. Possible values are:
    ///   * DELETE
    ///   * DISABLE
    ///   * ABANDON
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// The current state of the regional secret version.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// If set to &#39;true&#39;, the secret data is expected to be base64-encoded string and would be sent as is.
    /// </summary>
    public TerraformProperty<bool>? IsSecretDataBase64
    {
        get => GetProperty<TerraformProperty<bool>>("is_secret_data_base64");
        set => this.WithProperty("is_secret_data_base64", value);
    }

    /// <summary>
    /// Secret Manager regional secret resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretData is required")]
    public required TerraformProperty<string> SecretData
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret_data");
        set => this.WithProperty("secret_data", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecretManagerRegionalSecretVersionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSecretManagerRegionalSecretVersionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time at which the regional secret version was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The customer-managed encryption configuration of the regional secret.
    /// </summary>
    public TerraformExpression CustomerManagedEncryption => this["customer_managed_encryption"];

    /// <summary>
    /// The time at which the regional secret version was destroyed. Only present if state is DESTROYED.
    /// </summary>
    public TerraformExpression DestroyTime => this["destroy_time"];

    /// <summary>
    /// Location of Secret Manager regional secret resource.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The resource name of the regional secret version. Format:
    /// &#39;projects/{{project}}/locations/{{location}}/secrets/{{secret_id}}/versions/{{version}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The version of the Regional Secret.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
