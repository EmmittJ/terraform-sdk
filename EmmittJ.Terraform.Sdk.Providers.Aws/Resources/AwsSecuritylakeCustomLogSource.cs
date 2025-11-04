using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securitylake_custom_log_source resource.
/// </summary>
public class AwsSecuritylakeCustomLogSource : TerraformResource
{
    public AwsSecuritylakeCustomLogSource(string name) : base("aws_securitylake_custom_log_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attributes");
        this.DeclareOutput("id");
        this.DeclareOutput("provider_details");
    }

    /// <summary>
    /// The event_classes attribute.
    /// </summary>
    public HashSet<string>? EventClasses
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("event_classes")?.Value;
        set => this.WithProperty("event_classes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    public string? SourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_name")?.Value;
        set => this.WithProperty("source_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public string? SourceVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_version")?.Value;
        set => this.WithProperty("source_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformExpression Attributes => this["attributes"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    public TerraformExpression ProviderDetails => this["provider_details"];

}
