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
        SetOutput("activation_code");
        SetOutput("expired");
        SetOutput("registration_count");
        SetOutput("description");
        SetOutput("expiration_date");
        SetOutput("iam_role");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("registration_limit");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformProperty<string> ExpirationDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration_date");
        set => SetProperty("expiration_date", value);
    }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRole is required")]
    public required TerraformProperty<string> IamRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role");
        set => SetProperty("iam_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The registration_limit attribute.
    /// </summary>
    public TerraformProperty<double> RegistrationLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("registration_limit");
        set => SetProperty("registration_limit", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
