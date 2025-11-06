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
    public string? DeletionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deletion_policy")?.Value;
        set => this.WithProperty("deletion_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The current state of the SecretVersion.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// If set to &#39;true&#39;, the secret data is expected to be base64-encoded string and would be sent as is.
    /// </summary>
    public bool? IsSecretDataBase64
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_secret_data_base64")?.Value;
        set => this.WithProperty("is_secret_data_base64", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Secret Manager secret resource
    /// </summary>
    public string? Secret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret")?.Value;
        set => this.WithProperty("secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB.
    /// </summary>
    public string? SecretData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_data")?.Value;
        set => this.WithProperty("secret_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret data. Must be no larger than 64KiB. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public string? SecretDataWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_data_wo")?.Value;
        set => this.WithProperty("secret_data_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Triggers update of secret data write-only. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public double? SecretDataWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("secret_data_wo_version")?.Value;
        set => this.WithProperty("secret_data_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
