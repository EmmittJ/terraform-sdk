using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_key_rings.
/// </summary>
public class GoogleKmsKeyRingsDataSource : TerraformDataSource
{
    public GoogleKmsKeyRingsDataSource(string name) : base("google_kms_key_rings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("key_rings");
    }

    /// <summary>
    /// 
    /// 					The filter argument is used to add a filter query parameter that limits which keys are retrieved by the data source: ?filter={{filter}}.
    /// 					Example values:
    /// 					
    /// 					* &amp;quot;name:my-key-&amp;quot; will retrieve key rings that contain &amp;quot;my-key-&amp;quot; anywhere in their name. Note: names take the form projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}.
    /// 					* &amp;quot;name=projects/my-project/locations/global/keyRings/my-key-ring&amp;quot; will only retrieve a key ring with that exact name.
    /// 					
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/sorting-and-filtering)
    /// 				
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A list of all the retrieved key rings
    /// </summary>
    public TerraformExpression KeyRings => this["key_rings"];

}
