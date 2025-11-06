using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_user_profile resource.
/// </summary>
public class AwsDatazoneUserProfile : TerraformResource
{
    public AwsDatazoneUserProfile(string name) : base("aws_datazone_user_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("details");
        this.DeclareOutput("id");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    public string? DomainIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_identifier")?.Value;
        set => this.WithProperty("domain_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_identifier attribute.
    /// </summary>
    public string? UserIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_identifier")?.Value;
        set => this.WithProperty("user_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public string? UserType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_type")?.Value;
        set => this.WithProperty("user_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The details attribute.
    /// </summary>
    public TerraformExpression Details => this["details"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
