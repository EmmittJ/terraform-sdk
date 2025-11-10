using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_secret_manager_secret_version ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleSecretManagerSecretVersionEphemeralResource : TerraformEphemeralResource
{
    public GoogleSecretManagerSecretVersionEphemeralResource(string name) : base("google_secret_manager_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("destroy_time");
        this.WithOutput("enabled");
        this.WithOutput("name");
        this.WithOutput("secret_data");
    }

    /// <summary>
    /// If true, the secret data returned will not get base64 decoded. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? IsSecretDataBase64
    {
        get => GetProperty<TerraformProperty<bool>>("is_secret_data_base64");
        set => this.WithProperty("is_secret_data_base64", value);
    }

    /// <summary>
    /// The project to get the secret version for. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The secret to get the secret version for.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    public required TerraformProperty<string> Secret
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// The version of the secret to get. If it is not provided, the latest version is retrieved.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
    /// True if the current state of the SecretVersion is enabled.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The resource name of the SecretVersion. Format: `projects/{{project}}/secrets/{{secret_id}}/versions/{{version}}`.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The secret data. No larger than 64KiB.
    /// </summary>
    public TerraformExpression SecretData => this["secret_data"];

}
