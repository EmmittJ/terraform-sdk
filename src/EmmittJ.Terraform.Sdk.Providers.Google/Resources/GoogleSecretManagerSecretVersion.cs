using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_secret_manager_secret_version resource.
/// </summary>
public class GoogleSecretManagerSecretVersion : TerraformResource
{
    public GoogleSecretManagerSecretVersion(string name) : base("google_secret_manager_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("destroy_time");
        this.DeclareOutput("name");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The deletion policy for the secret version. Setting &#39;ABANDON&#39; allows the resource
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
    /// The current state of the SecretVersion.
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
    /// Secret Manager secret resource
    /// </summary>
    public TerraformProperty<string>? Secret
    {
        get => GetProperty<TerraformProperty<string>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    public TerraformProperty<string>? SecretData
    {
        get => GetProperty<TerraformProperty<string>>("secret_data");
        set => this.WithProperty("secret_data", value);
    }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformProperty<string>? SecretDataWo
    {
        get => GetProperty<TerraformProperty<string>>("secret_data_wo");
        set => this.WithProperty("secret_data_wo", value);
    }

    /// <summary>
    /// Triggers update of secret data write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformProperty<double>? SecretDataWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("secret_data_wo_version");
        set => this.WithProperty("secret_data_wo_version", value);
    }

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time at which the Secret was destroyed. Only present if state is DESTROYED.
    /// </summary>
    public TerraformExpression DestroyTime => this["destroy_time"];

    /// <summary>
    /// The resource name of the SecretVersion. Format:
    /// &#39;projects/{{project}}/secrets/{{secret_id}}/versions/{{version}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The version of the Secret.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
