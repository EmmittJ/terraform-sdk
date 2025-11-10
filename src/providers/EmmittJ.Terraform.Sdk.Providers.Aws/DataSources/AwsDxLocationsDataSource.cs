using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_locations.
/// </summary>
public class AwsDxLocationsDataSource : TerraformDataSource
{
    public AwsDxLocationsDataSource(string name) : base("aws_dx_locations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("location_codes");
        SetOutput("id");
        SetOutput("region");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The location_codes attribute.
    /// </summary>
    public TerraformExpression LocationCodes => this["location_codes"];

}
