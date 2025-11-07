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
    public TerraformProperty<string>? DomainIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("domain_identifier");
        set => this.WithProperty("domain_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The user_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? UserIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("user_identifier");
        set => this.WithProperty("user_identifier", value);
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformProperty<string>? UserType
    {
        get => GetProperty<TerraformProperty<string>>("user_type");
        set => this.WithProperty("user_type", value);
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
