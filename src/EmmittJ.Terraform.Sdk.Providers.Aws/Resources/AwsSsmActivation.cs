using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_activation resource.
/// </summary>
public class AwsSsmActivation : TerraformResource
{
    public AwsSsmActivation(string name) : base("aws_ssm_activation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("activation_code");
        this.DeclareOutput("expired");
        this.DeclareOutput("registration_count");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    public TerraformProperty<string>? IamRole
    {
        get => GetProperty<TerraformProperty<string>>("iam_role");
        set => this.WithProperty("iam_role", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The registration_limit attribute.
    /// </summary>
    public TerraformProperty<double>? RegistrationLimit
    {
        get => GetProperty<TerraformProperty<double>>("registration_limit");
        set => this.WithProperty("registration_limit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The activation_code attribute.
    /// </summary>
    public TerraformExpression ActivationCode => this["activation_code"];

    /// <summary>
    /// The expired attribute.
    /// </summary>
    public TerraformExpression Expired => this["expired"];

    /// <summary>
    /// The registration_count attribute.
    /// </summary>
    public TerraformExpression RegistrationCount => this["registration_count"];

}
