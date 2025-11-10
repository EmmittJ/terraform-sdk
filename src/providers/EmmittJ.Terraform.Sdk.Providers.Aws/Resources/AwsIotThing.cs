using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing resource.
/// </summary>
public class AwsIotThing : TerraformResource
{
    public AwsIotThing(string name) : base("aws_iot_thing", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("default_client_id");
        SetOutput("version");
        SetOutput("attributes");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("thing_type_name");
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Attributes
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("attributes");
        set => SetProperty("attributes", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The thing_type_name attribute.
    /// </summary>
    public TerraformProperty<string> ThingTypeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("thing_type_name");
        set => SetProperty("thing_type_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_client_id attribute.
    /// </summary>
    public TerraformExpression DefaultClientId => this["default_client_id"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
